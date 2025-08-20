using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2PLibray.GRN
{
    public class ReturnGoodsClass
    {
        public int GoodsReturnId { get; set; }

        public string GoodsReturnCode { get; set; }

        public string FailedQCCode { get; set; }

        public int StatusId { get; set; }

        public string TransporterName { get; set; }

        public string TransportContactNo { get; set; }

        public int VehicleTypeId { get; set; }

        public string VehicleNo { get; set; }

        public DateTime AddedDate { get; set; }

        public string AddedBy { get; set; }
    }
}
