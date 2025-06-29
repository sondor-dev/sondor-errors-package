﻿using Sondor.Errors.Constants;
using Sondor.Errors.Exceptions;

namespace Sondor.Errors.Tests.Exceptions;

/// <summary>
/// Tests for the <see cref="ResourceAlreadyExistsException"/>.
/// </summary>
[TestFixture]
public class ResourceAlreadyExistsExceptionTests
{
    /// <summary>
    /// Ensures that <see cref="ResourceAlreadyExistsException"/> constructor with resource, property name, and property value sets properties correctly.
    /// </summary>
    [Test]
    public void Constructor()
    {
        // arrange
        const string resource = "TestResource";
        const string propertyName = "TestProperty";
        const string propertyValue = "TestValue";
        var expected = string.Format(ExceptionConstants.ResourceAlreadyExistsMessage, resource, propertyName,
            propertyValue);

        // act
        var exception = new ResourceAlreadyExistsException(resource, propertyName, propertyValue);
        
        // assert
        Assert.Multiple(() =>
        {
            Assert.That(exception.Resource, Is.EqualTo(resource));
            Assert.That(exception.PropertyName, Is.EqualTo(propertyName));
            Assert.That(exception.PropertyValue, Is.EqualTo(propertyValue));
            Assert.That(exception.Message, Is.EqualTo(expected));
        });
    }

    /// <summary>
    /// Ensures that <see cref="ResourceAlreadyExistsException"/> constructor with resource, property name, and property value sets properties correctly.
    /// </summary>
    [Test]
    public void Constructor_override_message()
    {
        // arrange
        const string resource = "TestResource";
        const string propertyName = "TestProperty";
        const string propertyValue = "TestValue";
        const string messageFormat = "Custom message format for {0} with {1} = {2}";
        var expected = string.Format(messageFormat, resource, propertyName, propertyValue);

        // act
        var exception = new ResourceAlreadyExistsException(messageFormat, resource, propertyName, propertyValue);

        // assert
        Assert.Multiple(() =>
        {
            Assert.That(exception.Resource, Is.EqualTo(resource));
            Assert.That(exception.PropertyName, Is.EqualTo(propertyName));
            Assert.That(exception.PropertyValue, Is.EqualTo(propertyValue));
            Assert.That(exception.Message, Is.EqualTo(expected));
        });
    }
}