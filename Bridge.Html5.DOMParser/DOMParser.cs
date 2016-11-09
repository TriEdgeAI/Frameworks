namespace Bridge.Html5
{
	/// <summary>
	/// DOMParser can parse XML or HTML source stored in a string into a DOM Document.
	/// </summary>
	[External]
	[Namespace(false)]
	[Name("DOMParser")]
	public class DOMParser
	{
		/// <summary>
		/// Constructs a new DOMParser object.
		/// </summary>
		public extern DOMParser();

		/// <summary>
		/// Builds an XMLDocument object from the specified string.
		/// </summary>
		/// <param name="xmlString">String that specifies the contents of the XML file to parse.</param>
		/// <param name="mimeType">String that specifies the content type of the string to parse. Can be one of the following:
		/// text/html
		/// text/xml
		/// application/xml
		/// application/xhtml+xml
		/// image/svg+xml
		/// </param>
		/// <returns></returns>
		public extern DocumentInstance ParseFromString(string xmlString, string mimeType);
	}
}