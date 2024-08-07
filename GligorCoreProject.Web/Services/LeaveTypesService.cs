﻿using AutoMapper;
using GligorCoreProject.Web.Data;
using GligorCoreProject.Web.Models.LeaveTypes;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GligorCoreProject.Web.Services
{
    public class LeaveTypesService : ILeaveTypesService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public LeaveTypesService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<LeaveTypeReadOnlyVM>> GetAllLeaveTypes()
        {
            var data = await _context.LeaveTypes.ToListAsync();
            var viewData = _mapper.Map<List<LeaveTypeReadOnlyVM>>(data);
            return viewData;
        }

        public async Task<T?> Get<T>(int id) where T : class
        {
            var data = await _context.LeaveTypes.FirstOrDefaultAsync(x => x.Id == id);
            if (data == null)
            {
                return null;
            }

            var viewData = _mapper.Map<T>(data);
            return viewData;
        }

        public async Task Edit(LeaveTypeEditVM model)
        {
            var leaveType = _mapper.Map<LeaveType>(model);
            _context.Update(leaveType);
            await _context.SaveChangesAsync();
        }

        public async Task Create(LeaveTypeCreateVM model)
        {
            var leaveType = _mapper.Map<LeaveType>(model);
            _context.Add(leaveType);
            await _context.SaveChangesAsync();
        }

        public bool LeaveTypeExists(int id)
        {
            return _context.LeaveTypes.Any(e => e.Id == id);
        }

        public async Task<bool> CheckIfLeaveTypeNameExist(string name)
        {
            var lowercaseName = name.ToLower();
            return await _context.LeaveTypes.AnyAsync(q => q.Name.ToLower().Equals(lowercaseName));
        }

        public async Task<bool> CheckIfLeaveTypeNameExistForEdit(LeaveTypeEditVM leaveTypeEdit)
        {
            var lowercaseName = leaveTypeEdit.Name.ToLower();
            return await _context.LeaveTypes.AnyAsync(q => q.Name.ToLower().Equals(lowercaseName) && q.Id != leaveTypeEdit.Id);
        }

        public async Task<IEnumerable<LeaveTypeReadOnlyVM>> GetAll()
        {
            var data = await _context.LeaveTypes.ToListAsync();
            var viewData = _mapper.Map<IEnumerable<LeaveTypeReadOnlyVM>>(data);
            return viewData;
        }

        public async Task Remove(int id)
        {
            var leaveType = await _context.LeaveTypes.FindAsync(id);
            if (leaveType != null)
            {
                _context.LeaveTypes.Remove(leaveType);
                await _context.SaveChangesAsync();
            }
        }
    }
}
