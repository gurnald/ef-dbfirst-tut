using ef_dbfirst_tut.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_dbfirst_tut;

public class OrderLinesController {

    private readonly SalesDbContext _context;

    public OrderLinesController() { 
                _context = new SalesDbContext();
    }

    public async Task<List<OrderLine>> GetAllAsync() {
        return await _context.OrderLines.ToListAsync();
    }
    
    public async Task<OrderLine?> GetByIdAsync(int id) {
        return await _context.OrderLines.FindAsync(id);
    }

    public async Task<bool> InsertAsync(OrderLine orderline) {
        _context.OrderLines.Add(orderline);
        var changes = await _context.SaveChangesAsync();
        return (changes == 1) ? true : false;
    }

    public async Task<bool> UpdateAsync(OrderLine orderline) {
        var orderLine = await GetByIdAsync(orderline.Id);
        if (orderline is null) {
            return false;
        }
        _context.Entry(orderline).State = EntityState.Modified;
        var changes = await _context.SaveChangesAsync();
        return (changes == 1) ? true : false;
    }

    public async Task<bool> DeleteAsync(int id) {
        var ordline = await GetByIdAsync(id);
        if (ordline is null) {
            return false;
        }

        _context.OrderLines.Remove(ordline);
        var changes = await _context.SaveChangesAsync();
        return (changes == 1) ? true : false;
    }
        //public async Task<OrderLine?> GetByOrderLineId(int oLId) {
        //return await _context.OrderLines.FindAsync(oLId);
    //}

}
