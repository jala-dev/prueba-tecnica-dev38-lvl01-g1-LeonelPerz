using BusinessLogic.Core;
using Data;
using Data.Entities;
using Presentation;
using Presentation.View;
using System.Collections.Generic;

namespace BusinessLogic.Commands
{
    public class MemberReceivableRequest: IWaterCommand
    {
        double WaterPrice = 8.5;
        public void Execute()
        {
            UserReceivableView view = new UserReceivableView();
            InputData data = view.RequestData();
            Member entity = new Member();
            entity.ID = int.Parse(data.fields["CodigoSocio"]);
            
            List<Consumption> memberConsumptions = new ConsumptionRepository().GetConsumptionByMember(entity);

            double total = CalculateTotalReceivable(memberConsumptions);
            int totalCubes = CalculateTotalCubes(memberConsumptions);

            view.ShowResult(entity.ID,totalCubes,total);               
        }

        private double CalculateTotalReceivable(List<Consumption> memberConsumptions)
        {
            double total = 0;
            foreach(Consumption item in memberConsumptions)
            {
                total += item.Value * WaterPrice;
            }
            return total;
        }

        private int CalculateTotalCubes(List<Consumption> memberConsumptions)
        {
            int total = 0;
            foreach (Consumption item in memberConsumptions)
            {
                total += item.Value;
            }

            return total;
        }
    }
}
