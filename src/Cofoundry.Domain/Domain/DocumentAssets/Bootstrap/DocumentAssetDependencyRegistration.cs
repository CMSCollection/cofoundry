﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cofoundry.Core.DependencyInjection;

namespace Cofoundry.Domain.Bootstrap
{
    public class DocumentAssetDependencyRegistration : IDependencyRegistration
    {
        public void Register(IContainerRegister container)
        {
            container
                .Register<DocumentAssetCommandHelper>()
                .Register<IDocumentAssetRouteLibrary, DocumentAssetRouteLibrary>()
                .Register<IDocumentAssetRepository, DocumentAssetRepository>()
                .Register<IDocumentAssetSummaryMapper, DocumentAssetSummaryMapper>()
                .Register<IDocumentAssetDetailsMapper, DocumentAssetDetailsMapper>()
                .Register<IDocumentAssetRenderDetailsMapper, DocumentAssetRenderDetailsMapper>()
                ;
        }
    }
}
