using Domain.Dtos;
using Domain.Entities;
using Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class AlbumService
    {
        private readonly AlbumRepository _albumRepository;
        public AlbumService(AlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }

        private bool ValidateAlbum(AlbumDto albumDto)
        {
            if (albumDto == null) { return false; }
            if(string.IsNullOrEmpty(albumDto.Name)) { return false; }
            return true;
        }

        public bool CreateAlbum(AlbumDto albumDto)
        {
            Album album = new Album();
            if(!ValidateAlbum(albumDto)) { return false; }
            try
            {
                album.Name = albumDto.Name;
                _albumRepository.Persist(album);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool UpdateAlbum(AlbumDto albumDto)
        {
            Album album = new Album();
            if (!ValidateAlbum(albumDto)) { return false; }
            try
            {
                album.Name = albumDto.Name;
                _albumRepository.Update(album);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
