using System.Collections.Generic;
using System.IO;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Fluid.Ast;
using OrchardCore.Liquid;

namespace OrchardCore.DisplayManagement.Liquid.Tags
{
    public interface IAnchorTag
    {
        bool Match(IReadOnlyList<FilterArgument> argumentsList);

        ValueTask<Completion> WriteToAsync(IReadOnlyList<FilterArgument> argumentsList, IReadOnlyList<Statement> statements, TextWriter writer, TextEncoder encoder, LiquidTemplateContext context);

        int Order { get; }
    }
}
