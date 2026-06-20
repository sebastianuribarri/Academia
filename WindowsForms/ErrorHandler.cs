
namespace WindowsForms
{
    internal static class ErrorHandler
    {
        public static async Task<bool> ExecuteApiCallAsync(Func<Task> apiCall)
        {
            try
            {
                await apiCall();
                return true;
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message.Replace("\"", "");
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
