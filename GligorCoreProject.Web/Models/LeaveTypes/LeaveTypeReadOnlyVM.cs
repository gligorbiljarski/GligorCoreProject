﻿namespace GligorCoreProject.Web.Models.LeaveTypes
{
    public class LeaveTypeReadOnlyVM

    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int NumberOfDays { get; set; }
    }
}