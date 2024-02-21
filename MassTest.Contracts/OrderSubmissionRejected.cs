using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassTest.Contracts
{
    public interface OrderSubmissionRejected
    {
        Guid OrderId { get; }
        DateTime? Timestamp { get; }
        public string CustomerNumber { get; }

        string Reason { get; }
    }
}
