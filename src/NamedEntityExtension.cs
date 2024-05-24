using Soenneker.Dtos.IdNamePair;
using Soenneker.Entities.Named.Abstract;

namespace Soenneker.Extensions.NamedEntity;

/// <summary>
/// A collection of helpful NamedEntity extension methods
/// </summary>
public static class NamedEntityExtension
{
    /// <summary>
    /// Converts an object implementing the <see cref="INamedEntity"/> interface to an <see cref="IdNamePair"/>.
    /// </summary>
    /// <typeparam name="T">The type of the object that implements <see cref="INamedEntity"/>.</typeparam>
    /// <param name="value">The object to convert. Must not be null.</param>
    /// <returns>An <see cref="IdNamePair"/> containing the Id and Name of the provided object.</returns>
    public static IdNamePair ToIdNamePair<T>(this T value) where T : INamedEntity
    {
        return new IdNamePair {Id = value.Id, Name = value.Name};
    }
}