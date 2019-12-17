using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapCollection
{
    public class Hero
    {
        private ICollection<Profession> _profession;
        public virtual Guid Id { get; set; }
        public virtual string Name{ get; set; }
        public virtual int MP { get; set; }
        public virtual int HP { get; set; }
        public virtual ICollection<Profession> Profession
        {
            get
            {
                return this._profession;
            }

            set
            {
                this._profession = value;
            }
        }
        
        public virtual void Add(Profession profession)
        {
            if (_profession == null)
            {
                _profession = new List<Profession>();
            }

            profession.Hero = this;
            _profession.Add(profession);
        }

    }
}
