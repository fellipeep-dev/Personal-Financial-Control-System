using Application.Dtos.Transaction;
using Application.Services.Transaction;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controller
{
    [Controller]
    [Route("[controller]")]
    public class TransactionController : ControllerBase
    {
        [HttpPost("create")]
        public async Task<IActionResult> CreateTransaction(
            [FromBody] CreateTransactionDto createTransactionDto,
            [FromServices] ICreateTransactionUseCase _createTransactionUseCase
        )
        {
            await _createTransactionUseCase.ExecuteAsync(createTransactionDto);

            return Ok(new { Message = "Transaction created successfully" });
        }

        [HttpGet("get")]
        public async Task<IActionResult> GetTransactions(
            [FromServices] IGetTransactionsUseCase _getTransactionsUseCase
        )
        {
            var transactions = await _getTransactionsUseCase.ExecuteAsync();

            return Ok(transactions);
        }

        [HttpGet("get/{id:guid}")]
        public async Task<IActionResult> GetTransactionById(
            [FromRoute] Guid id,
            [FromServices] IGetTransactionByIdUseCase _getTransactionByIdUseCase
        )
        {
            var transaction = await _getTransactionByIdUseCase.ExecuteAsync(id);

            return Ok(transaction);
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateTransaction(
            [FromBody] UpdateTransactionDto updateTransactionDto,
            [FromServices] IUpdateTransactionUseCase _updateTransactionUseCase
        )
        {
            await _updateTransactionUseCase.ExecuteAsync(updateTransactionDto);

            return Ok(new { Message = "Transaction updated successfully" });
        }

        [HttpDelete("delete/{id:guid}")]
        public async Task<IActionResult> DeleteTransaction(
            [FromRoute] Guid id,
            [FromServices] IDeleteTransactionUseCase _deleteTransactionUseCase)
        {
            await _deleteTransactionUseCase.ExecuteAsync(id);

            return Ok(new { Message = "Transaction deleted successfully" });
        }
    }
}
