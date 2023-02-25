﻿using System.Text;
using System.Xml;
using System.Xml.Linq;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="TextReader"/> type.</para>
/// </summary>
/// <seealso cref="TextReader"/>
public static class TextReaderConverters
{
  /// <summary>
  ///   <para>Converts given <see cref="TextReader"/> instance to the <see cref="byte"/> array.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="encoding">Text encoding to use or <see langword="null"/> for a default value.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="BytesAsync(IConversion{TextReader}, Encoding, string)"/>
  /// <seealso cref="TextReaderExtensions.ToBytes(TextReader, Encoding)"/>
  public static byte[] Bytes(this IConversion<TextReader> conversion, Encoding encoding = null, string error = null) => conversion.To(reader => reader.ToBytes(encoding), error);

  /// <summary>
  ///   <para>Asynchronously converts given <see cref="TextReader"/> instance to the instance of <see cref="Task{byte[]}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="encoding">Text encoding to use or <see langword="null"/> for a default value.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Bytes(IConversion{TextReader}, Encoding, string)"/>
  /// <seealso cref="TextReaderExtensions.ToBytesAsync(TextReader, Encoding)"/>
  public static Task<byte[]> BytesAsync(this IConversion<TextReader> conversion, Encoding encoding = null, string error = null) => conversion.To(reader => reader.ToBytesAsync(encoding), error);

  /// <summary>
  ///   <para>Converts given <see cref="TextReader"/> instance to the instance of <see cref="string"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="TextAsync(IConversion{TextReader}, string)"/>
  /// <seealso cref="TextReaderExtensions.ToText(TextReader)"/>
  public static string Text(this IConversion<TextReader> conversion, string error = null) => conversion.To(reader => reader.ToText(), error);

  /// <summary>
  ///   <para>Asynchronously converts given <see cref="TextReader"/> instance to the instance of <see cref="Task{string}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Text(IConversion{TextReader}, string)"/>
  /// <seealso cref="TextReaderExtensions.ToTextAsync(TextReader)"/>
  public static Task<string> TextAsync(this IConversion<TextReader> conversion, string error = null) => conversion.To(reader => reader.ToTextAsync(), error);

  /// <summary>
  ///   <para>Converts given <see cref="TextReader"/> instance to the instance of <see cref="System.Xml.XmlDocument"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="TextReaderExtensions.ToXmlDocument(TextReader)"/>
  public static XmlDocument XmlDocument(this IConversion<TextReader> conversion, string error = null) => conversion.To(reader => reader.ToXmlDocument(), error);

  /// <summary>
  ///   <para>Converts given <see cref="TextReader"/> instance to the instance of <see cref="System.Xml.XmlDocument"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="XDocumentAsync(IConversion{TextReader}, CancellationToken, string)"/>
  /// <seealso cref="TextReaderExtensions.ToXDocument(TextReader)"/>
  public static XDocument XDocument(this IConversion<TextReader> conversion, string error = null) => conversion.To(reader => reader.ToXDocument(), error);

  /// <summary>
  ///   <para>Asynchronously converts given <see cref="TextReader"/> instance to the instance of <see cref="Task{XDocument}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="cancellation">Token to use for asynchronous cancellation of conversion.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="XDocument(IConversion{TextReader}, string)"/>
  /// <seealso cref="TextReaderExtensions.ToXDocumentAsync(TextReader, CancellationToken)"/>
  public static Task<XDocument> XDocumentAsync(this IConversion<TextReader> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(reader => reader.ToXDocumentAsync(cancellation), error);

  /// <summary>
  ///   <para>Converts given <see cref="TextReader"/> instance to the instance of <see cref="IEnumerable{char}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="close">Whether to automatically close the reader's underlying stream after enumeration of the conversion result.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Enumerable(IConversion{TextReader}, int, bool, string)"/>
  /// <seealso cref="TextReaderExtensions.ToEnumerable(TextReader, bool)"/>
  public static IEnumerable<char> Enumerable(this IConversion<TextReader> conversion, bool close = false, string error = null) => conversion.To(reader => reader.ToEnumerable(close), error);

  /// <summary>
  ///   <para>Converts given <see cref="TextReader"/> instance to the instance of <see cref="IEnumerable{char[]}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="count">Size of bytes block to read.</param>
  /// <param name="close">Whether to automatically close the reader's underlying stream after enumeration of the conversion result.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Enumerable(IConversion{TextReader}, bool, string)"/>
  /// <seealso cref="TextReaderExtensions.ToEnumerable(TextReader, int, bool)"/>
  public static IEnumerable<char[]> Enumerable(this IConversion<TextReader> conversion, int count, bool close = false, string error = null) => conversion.To(reader => reader.ToEnumerable(count, close), error);

  /// <summary>
  ///   <para>Converts given <see cref="TextReader"/> instance to the instance of <see cref="IAsyncEnumerable{char}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="close">Whether to automatically close the reader's underlying stream after enumeration of the conversion result.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="AsyncEnumerable(IConversion{TextReader}, int, bool, string)"/>
  /// <seealso cref="TextReaderExtensions.ToAsyncEnumerable(TextReader, bool)"/>
  public static IAsyncEnumerable<char> AsyncEnumerable(this IConversion<TextReader> conversion, bool close = false, string error = null) => conversion.To(reader => reader.ToAsyncEnumerable(close), error);

  /// <summary>
  ///   <para>Converts given <see cref="TextReader"/> instance to the instance of <see cref="IAsyncEnumerable{char[]}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="count">Size of bytes block to read.</param>
  /// <param name="close">Whether to automatically close the reader's underlying stream after enumeration of the conversion result.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="AsyncEnumerable(IConversion{TextReader}, bool, string)"/>
  /// <seealso cref="TextReaderExtensions.ToAsyncEnumerable(TextReader, int, bool)"/>
  public static IAsyncEnumerable<char[]> AsyncEnumerable(this IConversion<TextReader> conversion, int count, bool close = false, string error = null) => conversion.To(reader => reader.ToAsyncEnumerable(count, close), error);
}