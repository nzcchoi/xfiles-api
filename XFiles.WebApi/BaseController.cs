using Global.Storage;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XFiles.Ef;

namespace XFiles.WebApi
{
    public abstract class BaseController : ControllerBase
    {
        public XFilesDbContext XFilesDbContext { get; }
        protected XFilesUnitOfWork XFilesUoW { get; }
        protected BlobService BlobService { get; }
        public BaseController(XFilesDbContext xFilesDbContext, BlobService blobService)
        {
            XFilesDbContext = xFilesDbContext;
            BlobService = blobService;
            XFilesUoW = new XFilesUnitOfWork(xFilesDbContext);
        }
    }
}
