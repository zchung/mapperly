using Riok.Mapperly.Abstractions;

namespace Riok.Mapperly.IntegrationTests.Mapper
{
    public partial record NestedTestMapperRecord(string Result)
    {
        public partial record TestNesting
        {
            [Mapper(EnabledConversions = MappingConversionType.ExplicitCast)]
            public static partial class NestedMapper
            {
                public static partial int ToInt(decimal value);
            }
        }
    }
}
