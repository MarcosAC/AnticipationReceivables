using AnticipationReceivables.Application.InputModels;
using AnticipationReceivables.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AnticipationReceivables.API.Controllers
{
    [Route("api/transactions")]
    public class TransactionsContoller : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionsContoller(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] NewTransactionInputModel inputModel)
        {
            var id = _transactionService.Create(inputModel);

            return CreatedAtAction(nameof(GetById), new { id = id }, inputModel);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var transaction = _transactionService.GetById(id);

            if (transaction == null)
            {
                return NotFound();
            }

            return Ok(transaction);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var projects = _transactionService.GetAll();

            return Ok(projects);
        }
    }
}
