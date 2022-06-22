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
    public class CommentService
    {
        private readonly HttpClient _httpClient;
        private readonly string BaseApiUrl = "https://localhost:44377/api/Imggy";
        public CommentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Comment>> GetAllComments()
        {
            return await _httpClient.GetFromJsonAsync<List<Comment>>(BaseApiUrl);
        }
        public async Task AddCommentAsync(Comment comment)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, BaseApiUrl);
            request.Content = new StringContent(JsonSerializer.Serialize(comment), Encoding.UTF8, "application/json");
            await _httpClient.SendAsync(request);
        }
        public async Task<Comment> GetCommentAsync(int commentId)
        {
            return await _httpClient.GetFromJsonAsync<Comment>($"{BaseApiUrl}/{commentId}");
        }
        public async Task UpdateCommentAsync(Comment comment)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, BaseApiUrl);
            request.Content = new StringContent(JsonSerializer.Serialize(comment), Encoding.UTF8, "application/json");
            await _httpClient.SendAsync(request);
        }
        public async Task DeleteCommentAsync(int commentId)
        {
            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, $"{BaseApiUrl}/{commentId}");
            await _httpClient.SendAsync(httpRequest);
        }
    }
}
