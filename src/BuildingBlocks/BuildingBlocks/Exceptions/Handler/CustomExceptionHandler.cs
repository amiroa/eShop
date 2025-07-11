using Microsoft.Extensions.Logging;

namespace BuildingBlocks.Exceptions.Handler;

public class CustomExceptionHandler(ILogger<CustomExceptionHandler> logger)
{
    //public async ValueTask<bool> TryHandleAsync(HttpContent context, Exception exception)
    //{
    //    logger.LogError("Error Message: {exceptionMessage}, Time of occurrence {time}",
    //        exception.Message, DateTime.UtcNow);

    //    (string Detail, string Title, int StatusCode) details = exception switch
    //    {
    //        InternalServerException =>
    //        (
    //            exception.Message,
    //            exception.GetType().Name,
    //            context.
    //        )
    //        ArgumentNullException => ("A required argument was null.", "Argument Null Exception", StatusCodes.Status400BadRequest),
    //        ArgumentException => ("An argument was invalid.", "Argument Exception", StatusCodes.Status400BadRequest),
    //        InvalidOperationException => ("The operation is not valid in the current state.", "Invalid Operation Exception", StatusCodes.Status400BadRequest),
    //        _ => ("An unexpected error occurred.", "Internal Server Error", StatusCodes.Status500InternalServerError)
    //    };
    //}
}
