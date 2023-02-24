﻿using System.Net.Sockets;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="TcpClient"/> type.</para>
/// </summary>
/// <seealso cref="TcpClient"/>
public static class TcpClientConverters
{
  /// <summary>
  ///   <para>Converts given <see cref="TcpClient"/> instance to the instance of <see cref="IEnumerable{byte}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="BytesAsync(IConversion{TcpClient}, string)"/>
  /// <seealso cref="TcpClientExtensions.ToBytes(TcpClient)"/>
  public static IEnumerable<byte> Bytes(this IConversion<TcpClient> conversion, string error = null) => conversion.To(tcp => tcp.ToBytes(), error);

  /// <summary>
  ///   <para>Asynchronously converts given <see cref="TcpClient"/> instance to the instance of <see cref="IAsyncEnumerable{byte}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Bytes(IConversion{TcpClient}, string)"/>
  /// <seealso cref="TcpClientExtensions.ToBytesAsync(TcpClient)"/>
  public static IAsyncEnumerable<byte> BytesAsync(this IConversion<TcpClient> conversion, string error = null) => conversion.To(tcp => tcp.ToBytesAsync(), error);

  /// <summary>
  ///   <para>Converts given <see cref="TcpClient"/> instance to the instance of <see cref="IEnumerable{byte}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="close"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Enumerable(IConversion{TcpClient}, int, bool, string)"/>
  /// <seealso cref="TcpClientExtensions.ToEnumerable(TcpClient, bool)"/>
  public static IEnumerable<byte> Enumerable(this IConversion<TcpClient> conversion, bool close = false, string error = null) => conversion.To(tcp => tcp.ToEnumerable(close), error);

  /// <summary>
  ///   <para>Converts given <see cref="TcpClient"/> instance to the instance of <see cref="IEnumerable{byte[]}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="count"></param>
  /// <param name="close"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Enumerable(IConversion{TcpClient}, bool, string)"/>
  /// <seealso cref="TcpClientExtensions.ToEnumerable(TcpClient, int, bool)"/>
  public static IEnumerable<byte[]> Enumerable(this IConversion<TcpClient> conversion, int count, bool close = false, string error = null) => conversion.To(tcp => tcp.ToEnumerable(count, close), error);

  /// <summary>
  ///   <para>Converts given <see cref="TcpClient"/> instance to the instance of <see cref="IAsyncEnumerable{byte}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="close"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="AsyncEnumerable(IConversion{TcpClient}, int, bool, string)"/>
  /// <seealso cref="TcpClientExtensions.ToAsyncEnumerable(TcpClient, bool)"/>
  public static IAsyncEnumerable<byte> AsyncEnumerable(this IConversion<TcpClient> conversion, bool close = false, string error = null) => conversion.To(tcp => tcp.ToAsyncEnumerable(close), error);

  /// <summary>
  ///   <para>Converts given <see cref="TcpClient"/> instance to the instance of <see cref="IAsyncEnumerable{byte[]}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="count"></param>
  /// <param name="close"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="AsyncEnumerable(IConversion{TcpClient}, bool, string)"/>
  /// <seealso cref="TcpClientExtensions.ToAsyncEnumerable(TcpClient, int, bool)"/>
  public static IAsyncEnumerable<byte[]> AsyncEnumerable(this IConversion<TcpClient> conversion, int count, bool close = false, string error = null) => conversion.To(tcp => tcp.ToAsyncEnumerable(count, close), error);
}