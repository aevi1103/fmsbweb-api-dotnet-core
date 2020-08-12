using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.QualityCheckSheets;
using FmsbwebCoreApi.Entity.QualityCheckSheets;
using FmsbwebCoreApi.Repositories.QualityCheckSheets;
using FmsbwebCoreApi.Services.Interfaces;
using FmsbwebCoreApi.Services.Interfaces.QualityCheckSheets;

namespace FmsbwebCoreApi.Services.QualityCheckSheets
{
    public class OrganizationPartService : OrganizationPartRepository, IOrganizationPartService
    {
        public OrganizationPartService(QualityCheckSheetsContext context) : base(context)
        {
        }

        public override async Task<OrganizationPart> Create(OrganizationPart data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            var isExist = await IsPartExist(data.LeftHandPart, data.RightHandPart).ConfigureAwait(false);

            if (!isExist)
                return await base.Create(data).ConfigureAwait(false);

            throw new OperationCanceledException($"Unable to create part number because {data.LeftHandPart} - {data.RightHandPart} already exist in the database");
        }

        public override async Task<OrganizationPart> Update(OrganizationPart data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            var isExist = await IsPartExist(data.LeftHandPart, data.RightHandPart).ConfigureAwait(false);

            if (!isExist)
                return await base.Update(data).ConfigureAwait(false);

            throw new OperationCanceledException($"Unable to update part number because {data.LeftHandPart} - {data.RightHandPart} already exist in the database");
        }
    }
}
