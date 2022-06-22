using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Service.Services
{
    public class AlbumService
    {
        private readonly HttpClient _httpClient;
        private readonly string BaseApiUrl = "https://localhost:44377/api/Imggy";
        public AlbumService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Album>> GetAllAlbum()
        {
            return await _httpClient.GetFromJsonAsync<List<Album>>(BaseApiUrl);
        }
        public async Task AddAlbumAsync(Album album)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, BaseApiUrl);
            request.Content = new StringContent(JsonSerializer.Serialize(album), Encoding.UTF8, "application/json");
            await _httpClient.SendAsync(request);
        }
        public async Task<Album> GetAlbumAsync(int albumId)
        {
            return await _httpClient.GetFromJsonAsync<Album>($"{BaseApiUrl}/{albumId}");
        }
        public async Task UpdateAlbumAsync(Album album)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, BaseApiUrl);
            request.Content = new StringContent(JsonSerializer.Serialize(album), Encoding.UTF8, "application/json");
            await _httpClient.SendAsync(request);
        }
        public async Task DeleteAlbumAsync(int albumId)
        {
            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, $"{BaseApiUrl}/{albumId}");
            await _httpClient.SendAsync(httpRequest);
        }
    }
}

