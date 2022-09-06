using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Data.DB;
using Data.Entities;
using Presentation;
using Presentation.View;

namespace BusinessLogic.Commands
{
    class SaveMember
    {
        public void Execute()
        {
            SaveMemberView view = new SaveMemberView();
            Member entity = new Member();
            InputData data = view.RequestData();
            entity.ID = int.Parse(data.fields["ID"]);
            entity.FirstName = data.fields["FirstName"];
            entity.SecondName = data.fields["SecondName"];

            LocalMemoryDB.MembersContext.Add(entity);

        }
    }
}
