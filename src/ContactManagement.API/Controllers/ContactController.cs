using ContactManagement.Application.ContactService.Commands.CreateContact;
using ContactManagement.Application.ContactService.Commands.DeleteContact;
using ContactManagement.Application.ContactService.Commands.Update;
using ContactManagement.Application.ContactService.Queries.GetContactById;
using ContactManagement.Application.ContactService.Queries.GetContacts;
using ContactManagement.Application.ContactService.Queries.GetContactsByUserId;
using ContactManagement.Domain.Contacts;
using ContactManagement.Domain.Users;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ContactManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
       private readonly ISender _mediator;
        private readonly IValidator<CreateContactCommand> _validator;

        public ContactController(ISender mediator, IValidator<CreateContactCommand> validator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _validator = validator;
        }

        [HttpGet("GetContacts")]
        public async Task<ActionResult> GetAllContacts()
        {
            var contacts = await _mediator.Send(new GetContactQuery());
            return Ok(contacts);
        }

        [HttpGet("GetById/{id}")]
        public async Task<ActionResult> GetContactById(string id)
        {
            var contact = await _mediator.Send(new GetContactByIdQuery { Id = new ContactId(Guid.Parse(id)) });
            return Ok(contact);
        }

        [HttpGet("GetByUserId/{id}")]
        public async Task<ActionResult> GetContactByUserId(string id)
        {
            var contact = await _mediator.Send(new GetContactsByUserIdQuery { Id = new UserId(Guid.Parse(id)) });
            return Ok(contact);
        }

        [HttpPost]
        public async Task<ActionResult> CreateContact([FromBody] CreateContactCommand command)
        {
            var validationResult = _validator.Validate(command);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            var contact = await _mediator.Send(command);
            return Ok(contact);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteContact([FromBody] ContactId id)
        {
            var contact = await _mediator.Send(new DeleteContactCommand { Id = id });
            return Ok(contact);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateContact([FromBody] UpdateContactCommand command)
        {
            var contact = await _mediator.Send(command);
            return Ok(contact);
        }
        
    }
}
