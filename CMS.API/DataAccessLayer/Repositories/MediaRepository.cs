﻿using AutoMapper;
using CMS.API.DataAccessLayer.Interfaces;
using CMS.API.DataAccessLayer.Models;

namespace CMS.API.DataAccessLayer.Repositories
{
    public class MediaRepository : GenericRepository<UploadResult>, IMediaRepository
    {
        private readonly CMSDbContext _context;
        private readonly IMapper _mapper;

        public MediaRepository(CMSDbContext context, IMapper mapper) : base(context, mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }
    }
}
