using System.Collections.Generic;
using System.Threading.Tasks;
using GligorCoreProject.Web.Models.LeaveTypes;

namespace GligorCoreProject.Web.Services
{
    public interface ILeaveTypesService
    {
        Task<bool> CheckIfLeaveTypeNameExist(string name);
        Task<bool> CheckIfLeaveTypeNameExistForEdit(LeaveTypeEditVM leaveTypeEdit);
        Task Create(LeaveTypeCreateVM model);
        Task Edit(LeaveTypeEditVM model);
        Task<T?> Get<T>(int id) where T : class;
        Task<List<LeaveTypeReadOnlyVM>> GetAllLeaveTypes();
        bool LeaveTypeExists(int id);
        Task<IEnumerable<LeaveTypeReadOnlyVM>> GetAll();
        Task Remove(int id);
    }

    public class LeaveTypeViewModel
    {
    }
}
