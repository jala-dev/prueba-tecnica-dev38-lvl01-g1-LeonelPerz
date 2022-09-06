using Data;
using Data.Entities;
using Presentation;
using Presentation.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Commands
{
    class SavePayment
    {
        MemberRepository repository = new MemberRepository();
        ConsumptionRepository consumptionRepository = new ConsumptionRepository();
        public void Execute()
        {
            SavePaymentView view = new SavePaymentView();
            InputData data = view.RequestData();
            Member entity = repository.GetMember(int.Parse(data.fields["CodigoSocio"]));
            

            if (entity == null)
            {
                Console.WriteLine("El codigo de socio no existe");
            }
            else
            {
                foreach (var item in consumptionRepository.GetConsumptionByMember(entity))
                {
                    item.Paid = true;
                }
                view.ShowResult(entity.FirstName + " " + entity.SecondName);
            }


        }
    }
}
