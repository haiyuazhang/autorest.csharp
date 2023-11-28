// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel.Internal;

namespace OpenAI.Models
{
    /// <summary> The CreateTranslationResponse. </summary>
    public partial class CreateTranslationResponse
    {
        /// <summary> Initializes a new instance of <see cref="CreateTranslationResponse"/>. </summary>
        /// <param name="text"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> is null. </exception>
        internal CreateTranslationResponse(string text)
        {
            ClientUtilities.AssertNotNull(text, nameof(text));

            Text = text;
        }

        /// <summary> Gets the text. </summary>
        public string Text { get; }
    }
}
