using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Global.Storage;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using XFiles.Ef;
using XFiles.Models;

namespace XFiles.WebApi.Controllers
{
    // [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ProjectsController : BaseController
    {
        private readonly ILogger<ProjectsController> _logger;
        ProjectsController(ILogger<ProjectsController> logger, XFilesDbContext xFilesDbContext, BlobService blobService) : base(xFilesDbContext, blobService)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<Project>> Get()
        {
            return await XFilesUoW.ProjectRep.GetAllAsync();
        }
    }
}
