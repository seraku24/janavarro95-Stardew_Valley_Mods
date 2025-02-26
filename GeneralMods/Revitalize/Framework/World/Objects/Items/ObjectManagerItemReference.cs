using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Netcode;
using StardewValley;

namespace Omegasis.Revitalize.Framework.World.Objects.Items
{
    [XmlType("Mods_Revitalize.Framework.World.Objects.Items.ObjectManagerItemReference")]
    public class ObjectManagerItemReference : ItemReference
    {

        public readonly NetString itemId = new NetString();

        public ObjectManagerItemReference()
        {

        }

        public ObjectManagerItemReference(string ItemId, int StackSize = 1) : base(StackSize)
        {
            this.itemId.Value = ItemId;
        }

        public override Item getItem(int StackSize = 1)
        {
            return RevitalizeModCore.ModContentManager.objectManager.getItem(this.itemId.Value, StackSize);
        }

        public override List<INetSerializable> getNetFields()
        {
            List<INetSerializable> netFields = base.getNetFields();
            netFields.Add(this.itemId);
            return netFields;
        }

        public override ItemReference readItemReference(BinaryReader reader)
        {
            base.readItemReference(reader);
            this.itemId.Value = reader.ReadString();
            return this;
        }

        public override void writeItemReference(BinaryWriter writer)
        {
            base.writeItemReference(writer);
            writer.Write(this.itemId.Value);
        }
    }
}
