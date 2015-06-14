using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorCountApp.DAL.Gateway;
using VisitorCountApp.DAL.Model;

namespace VisitorCountApp.BLL
{
    class VisitorManager
    {
        VisitorGateway visitorGateway = new VisitorGateway();

        public void SaveVisitor(Visitor aVisitor)
        {
        visitorGateway.SaveVisitor(aVisitor) ;
        }
        public List<Visitor> GetSelectedZoneVisitor(int id)
        {
            return visitorGateway.GetSelectedZoneVisitors(id);
        }
    }
}
