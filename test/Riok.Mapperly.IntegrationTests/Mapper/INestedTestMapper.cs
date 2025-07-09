using Riok.Mapperly.Abstractions;

namespace Riok.Mapperly.IntegrationTests.Mapper
{
    public partial interface INestedTestMapper
    {
        [Mapper(EnabledConversions = MappingConversionType.ExplicitCast)]
        public static partial class NestedMapper
        {
            public static partial int ToInt(decimal value);
        }
    }
}
