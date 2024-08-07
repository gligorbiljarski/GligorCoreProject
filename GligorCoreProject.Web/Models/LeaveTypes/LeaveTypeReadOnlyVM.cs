﻿using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel.DataAnnotations;

namespace GligorCoreProject.Web.Models.LeaveTypes
{
    public class LeaveTypeReadOnlyVM : BaseLeaveTypeVM

    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Maximum Allocation of Days")]


        public int NumberOfDays { get; set; }
    }
}
