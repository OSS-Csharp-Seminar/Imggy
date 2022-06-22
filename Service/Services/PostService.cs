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
    public class PostService
    {
        private readonly HttpClient _httpClient;
        private readonly string BaseApiUrl = "https://localhost:44377/api/Imggy";
        public PostService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Post>> GetAllPosts()
        {
            return await _httpClient.GetFromJsonAsync<List<Post>>(BaseApiUrl);
        }
        public async Task AddPostAsync(Post post)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, BaseApiUrl);
            request.Content = new StringContent(JsonSerializer.Serialize(post), Encoding.UTF8, "application/json");
            await _httpClient.SendAsync(request);
        }
        public async Task<Post> GetPostAsync(int postId)
        {
            return await _httpClient.GetFromJsonAsync<Post>($"{BaseApiUrl}/{postId}");
        }
        public async Task UpdatePostAsync(Post post)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, BaseApiUrl);
            request.Content = new StringContent(JsonSerializer.Serialize(post), Encoding.UTF8, "application/json");
            await _httpClient.SendAsync(request);
        }
        public async Task DeletePostAsync(int postId)
        {
            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, $"{BaseApiUrl}/{postId}");
            await _httpClient.SendAsync(httpRequest);
        }
    }
}
