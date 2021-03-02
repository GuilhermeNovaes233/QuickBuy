using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Domain.Entities
{
    public abstract class Entity
    {
        private List<string> _validationMessages { get; set; }
        private List<string> validationMessage
        {
            get { return _validationMessages ?? (_validationMessages = new List<string>()); }
        }

        protected void CleanMessagesValidation()
        {
            validationMessage.Clear();
        }

        protected void AddErrorMessage(string mensagem)
        {
            validationMessage.Add(mensagem);
        }

        public string GetMessagesValidation()
        {
            return string.Join(". ", validationMessage);
        }

        public abstract void Validate();
        public bool IsValid
        {
            get { return !validationMessage.Any(); }
        }
    }
}