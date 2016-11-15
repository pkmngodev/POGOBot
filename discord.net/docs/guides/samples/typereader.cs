using Discord;
using Discord.Commands;

public class BooleanTypeReader : TypeReader
{
    public override Task<TypeReaderResult> Read(IUserMessage context, string input)
    {
        bool result;
        if (bool.TryParse(input, out result))
            return Task.FromResult(TypeReaderResult.FromSuccess(result));
        
        return Task.FromResult(TypeReaderResult.FromError(CommandError.ParseFailed, "Input could not be parsed as a boolean."))
    }
}