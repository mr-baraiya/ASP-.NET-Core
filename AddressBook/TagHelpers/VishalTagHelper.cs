using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AddressBook.TagHelpers
{
    [HtmlTargetElement("vishal")]
    public class VishalTagHelper : TagHelper
    {
        public string Name { get; set; } = string.Empty;
        public string Text { get; set; } = "Image"; // Default alt text

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            
            output.TagName = "img"; // Change <vishal> to <img>
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Attributes.SetAttribute("src", Name);
            output.Attributes.SetAttribute("alt", Text);
        }
    }
}
