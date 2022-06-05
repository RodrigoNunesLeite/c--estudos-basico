using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_s11_e155.entities.exceptions {
    class DomainException: ApplicationException {
        public DomainException(string message): base(message) {

        }
    }
}
