using System.Collections.Generic;
using System.Threading.Tasks;
using TodoRestXF.Models;

namespace TodoRestXF.Data
{
    public interface IRestService
	{
		Task<List<TodoItem>> RefreshDataAsync();

		Task SaveTodoItemAsync(TodoItem item, bool isNewItem);

		Task DeleteTodoItemAsync(string id);
	}
}
