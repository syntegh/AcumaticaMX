using PX.Data;
using PX.Objects.SO;

namespace AcumaticaMX
{
    [PXTable(typeof(SOAddress.addressID), IsOptional = true)]
    public class MXSOAddressExtension : PXCacheExtension<PX.Objects.SO.SOAddress>
    {
        #region Street

        public abstract class street : IBqlField
        {
        }

        [PXDBString(50, IsUnicode = true)]
        [CompositeField(typeof(SOAddress.addressLine1), typeof(street), typeof(extNumber))]
        [PXUIField(DisplayName = "Calle", Visibility = PXUIVisibility.SelectorVisible)]
        public virtual string Street { get; set; }

        #endregion Street

        #region ExtNumber

        public abstract class extNumber : IBqlField
        {
        }

        [PXDBString(50, IsUnicode = true)]
        [CompositeField(typeof(SOAddress.addressLine1), typeof(street), typeof(extNumber))]
        [PXUIField(DisplayName = "Número Exterior", Visibility = PXUIVisibility.SelectorVisible)]
        public virtual string ExtNumber { get; set; }

        #endregion ExtNumber

        #region IntNumber

        public abstract class intNumber : IBqlField
        {
        }

        [PXDBString(50, IsUnicode = true)]
        [CompositeField(typeof(SOAddress.addressLine2), typeof(intNumber))]
        [PXUIField(DisplayName = "Número Interior", Visibility = PXUIVisibility.SelectorVisible)]
        public virtual string IntNumber { get; set; }

        #endregion IntNumber

        #region Neighborhood

        public abstract class neighborhood : IBqlField
        {
        }

        [PXDBString(50, IsUnicode = true)]
        [PXUIField(DisplayName = "Colonia", Visibility = PXUIVisibility.SelectorVisible)]
        public virtual string Neighborhood { get; set; }

        #endregion Neighborhood

        #region Municipality

        public abstract class municipality : IBqlField
        {
        }

        [PXDBString(50, IsUnicode = true)]
        [CompositeField(typeof(SOAddress.addressLine3), typeof(municipality))]
        [PXUIField(DisplayName = "Municipio/Delegación", Visibility = PXUIVisibility.SelectorVisible)]
        public virtual string Municipality { get; set; }

        #endregion Municipality

        #region Reference

        public abstract class reference : IBqlField
        {
        }

        [PXDBString(100, IsUnicode = true)]
        [PXUIField(DisplayName = "Referencia", Visibility = PXUIVisibility.SelectorVisible)]
        public virtual string Reference { get; set; }

        #endregion Reference
    }
}