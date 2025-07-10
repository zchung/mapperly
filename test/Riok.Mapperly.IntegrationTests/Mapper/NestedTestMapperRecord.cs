using Riok.Mapperly.Abstractions;

namespace Riok.Mapperly.IntegrationTests.Mapper
{
    public partial record NestedTestMapperRecord(string Result)
    {
        public partial record TestNesting
        {
            [Mapper(EnabledConversions = MappingConversionType.All)]
            public static partial class NestedMapper
            {
                public static partial int ToInt(decimal value);
            }
        }
    }
}
