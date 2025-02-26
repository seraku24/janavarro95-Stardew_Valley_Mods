using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Netcode;

namespace Omegasis.Revitalize.Framework.Utilities
{
    public class NetIntRange : NetField<IntRange, NetIntRange>
    {
        [XmlIgnore]
        public int Min
        {
            get
            {
                return this.value.min.Value;
            }
            set
            {
                this.value.min.Value = value;
            }
        }

        [XmlIgnore]
        public int Max
        {
            get
            {
                return this.value.max.Value;
            }
            set
            {
                this.value.max.Value = value;
            }
        }

        public NetIntRange()
        {

        }

        public NetIntRange(IntRange value) : base(value)
        {

        }

        public override void Set(IntRange newValue)
        {
            if (this.canShortcutSet())
                this.value = newValue;
            else if (newValue != this.value)
            {
                this.cleanSet(newValue);
                this.MarkDirty();
            }
        }

        protected override void ReadDelta(BinaryReader reader, NetVersion version)
        {

            if (this.value == null)
                this.value = new IntRange();

            if (version.IsPriorityOver(this.ChangeVersion))
            {
                this.value.readIntRange(reader);
                this.setInterpolationTarget(this.value);
            }
        }

        protected override void WriteDelta(BinaryWriter writer)
        {

            if (this.value == null)
                this.value = new IntRange();
            this.value.writeIntRange(writer);
        }

        public int getRandomInclusive()
        {
            return this.value.getRandomInclusive();
        }

        public int getRandomExclusive()
        {
            return this.value.getRandomExclusive();
        }
    }
}
