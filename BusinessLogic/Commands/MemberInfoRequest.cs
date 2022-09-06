using Data;
using System;
using Data.Entities;
using Presentation;
using Presentation.View;

namespace BusinessLogic.Commands
{
    class MemberInfoRequest
    {
        public void Execute()
        {
            MemberInfoView view = new MemberInfoView();
            InputData data = view.RequestData();
            Member entity = new Member();
            entity.ID = int.Parse(data.fields["CodigoSocio"]);

            Member member = new MemberRepository().GetMember(entity.ID);
            if(member == null)
            {
                Console.WriteLine("el código ingresado no existe en el sistema");
            }
            else
            {
                view.ShowResult(member.FirstName + " " + member.SecondName);
            }
        }
    }
}
