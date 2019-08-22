// Name: ASPNET Lab02
// Author: James Smelser
// Date: August 20, 2019
using System;

namespace PartyInvites.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}