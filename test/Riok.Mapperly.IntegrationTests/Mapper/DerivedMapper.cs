using Riok.Mapperly.Abstractions;

namespace Riok.Mapperly.IntegrationTests.Mapper
{
    [Mapper(EnabledConversions = MappingConversionType.ExplicitCast | MappingConversionType.ImplicitCast)]
    public partial class BaseMapper
    {
        public virtual partial long IntToLong(int value);

        public partial short IntToShort(int value);
    }

    [Mapper(EnabledConversions = MappingConversionType.ImplicitCast)]
    public partial class DerivedMapper : BaseMapper
    {
        public override partial long IntToLong(int value);
    }

    [Mapper(EnabledConversions = MappingConversionType.ExplicitCast | MappingConversionType.ImplicitCast)]
    public partial class DerivedMapper2 : BaseMapper
    {
        public sealed override partial long IntToLong(int value);

        public new partial short IntToShort(int value);
    }
}
