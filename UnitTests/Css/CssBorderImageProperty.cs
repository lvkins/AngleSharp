﻿using AngleSharp.DOM.Css;
using AngleSharp.DOM.Css.Properties;
using AngleSharp.Parser.Css;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Css
{
    [TestClass]
    public class CssBorderImagePropertyTests
    {
        [TestMethod]
        public void CssBorderImageSourceNoneLegal()
        {
            var snippet = "border-image-source: none    ";
            var property = CssParser.ParseDeclaration(snippet);
            Assert.AreEqual("border-image-source", property.Name);
            Assert.IsFalse(property.Important);
            Assert.IsInstanceOfType(property, typeof(CSSBorderImageSourceProperty));
            var concrete = (CSSBorderImageSourceProperty)property;
            Assert.AreEqual(CssValueType.PrimitiveValue, concrete.Value.CssValueType);
            Assert.IsFalse(concrete.IsInherited);
            Assert.IsTrue(concrete.HasValue);
            Assert.AreEqual("none", concrete.Value.CssText);
        }

        [TestMethod]
        public void CssBorderImageSourceUrlLegal()
        {
            var snippet = "border-image-source: url(image.jpg)";
            var property = CssParser.ParseDeclaration(snippet);
            Assert.AreEqual("border-image-source", property.Name);
            Assert.IsFalse(property.Important);
            Assert.IsInstanceOfType(property, typeof(CSSBorderImageSourceProperty));
            var concrete = (CSSBorderImageSourceProperty)property;
            Assert.AreEqual(CssValueType.PrimitiveValue, concrete.Value.CssValueType);
            Assert.IsFalse(concrete.IsInherited);
            Assert.IsTrue(concrete.HasValue);
            Assert.AreEqual("url('image.jpg')", concrete.Value.CssText);
        }

        [TestMethod]
        public void CssBorderImageSourceLinearGradientLegal()
        {
            var snippet = "border-image-source: linear-gradient(to top, red, yellow)";
            var property = CssParser.ParseDeclaration(snippet);
            Assert.AreEqual("border-image-source", property.Name);
            Assert.IsFalse(property.Important);
            Assert.IsInstanceOfType(property, typeof(CSSBorderImageSourceProperty));
            var concrete = (CSSBorderImageSourceProperty)property;
            Assert.AreEqual(CssValueType.Custom, concrete.Value.CssValueType);
            Assert.IsFalse(concrete.IsInherited);
            Assert.IsTrue(concrete.HasValue);
            Assert.AreEqual("linear-gradient(0deg, rgba(255, 0, 0, 1) 0%, rgba(255, 255, 0, 1) 100%)", concrete.Value.CssText);
        }

        [TestMethod]
        public void CssBorderImageOutsetZeroLegal()
        {
            var snippet = "border-image-outset: 0";
            var property = CssParser.ParseDeclaration(snippet);
            Assert.AreEqual("border-image-outset", property.Name);
            Assert.IsFalse(property.Important);
            Assert.IsInstanceOfType(property, typeof(CSSBorderImageOutsetProperty));
            var concrete = (CSSBorderImageOutsetProperty)property;
            Assert.AreEqual(CssValueType.PrimitiveValue, concrete.Value.CssValueType);
            Assert.IsFalse(concrete.IsInherited);
            Assert.IsTrue(concrete.HasValue);
            Assert.AreEqual("0", concrete.Value.CssText);
        }

        [TestMethod]
        public void CssBorderImageOutsetLengthPercentLegal()
        {
            var snippet = "border-image-outset: 10px   25%";
            var property = CssParser.ParseDeclaration(snippet);
            Assert.AreEqual("border-image-outset", property.Name);
            Assert.IsFalse(property.Important);
            Assert.IsInstanceOfType(property, typeof(CSSBorderImageOutsetProperty));
            var concrete = (CSSBorderImageOutsetProperty)property;
            Assert.AreEqual(CssValueType.ValueList, concrete.Value.CssValueType);
            Assert.IsFalse(concrete.IsInherited);
            Assert.IsTrue(concrete.HasValue);
            Assert.AreEqual("10px 25%", concrete.Value.CssText);
        }

        [TestMethod]
        public void CssBorderImageOutsetLengthPercentZeroLegal()
        {
            var snippet = "border-image-outset: 10px   25% 0";
            var property = CssParser.ParseDeclaration(snippet);
            Assert.AreEqual("border-image-outset", property.Name);
            Assert.IsFalse(property.Important);
            Assert.IsInstanceOfType(property, typeof(CSSBorderImageOutsetProperty));
            var concrete = (CSSBorderImageOutsetProperty)property;
            Assert.AreEqual(CssValueType.ValueList, concrete.Value.CssValueType);
            Assert.IsFalse(concrete.IsInherited);
            Assert.IsTrue(concrete.HasValue);
            Assert.AreEqual("10px 25% 0", concrete.Value.CssText);
        }

        [TestMethod]
        public void CssBorderImageOutsetLengthPercentZeroPercentLegal()
        {
            var snippet = "border-image-outset: 10px   25% 0 10%";
            var property = CssParser.ParseDeclaration(snippet);
            Assert.AreEqual("border-image-outset", property.Name);
            Assert.IsFalse(property.Important);
            Assert.IsInstanceOfType(property, typeof(CSSBorderImageOutsetProperty));
            var concrete = (CSSBorderImageOutsetProperty)property;
            Assert.AreEqual(CssValueType.ValueList, concrete.Value.CssValueType);
            Assert.IsFalse(concrete.IsInherited);
            Assert.IsTrue(concrete.HasValue);
            Assert.AreEqual("10px 25% 0 10%", concrete.Value.CssText);
        }

        [TestMethod]
        public void CssBorderImageOutsetZerosIllegal()
        {
            var snippet = "border-image-outset: 0 0 0 0 0";
            var property = CssParser.ParseDeclaration(snippet);
            Assert.AreEqual("border-image-outset", property.Name);
            Assert.IsFalse(property.Important);
            Assert.IsInstanceOfType(property, typeof(CSSBorderImageOutsetProperty));
            var concrete = (CSSBorderImageOutsetProperty)property;
            Assert.AreEqual(CssValueType.Inherit, concrete.Value.CssValueType);
            Assert.IsFalse(concrete.IsInherited);
            Assert.IsFalse(concrete.HasValue);
        }

        [TestMethod]
        public void CssBorderImageWidthZeroLegal()
        {
            var snippet = "border-image-width: 0";
            var property = CssParser.ParseDeclaration(snippet);
            Assert.AreEqual("border-image-width", property.Name);
            Assert.IsFalse(property.Important);
            Assert.IsInstanceOfType(property, typeof(CSSBorderImageWidthProperty));
            var concrete = (CSSBorderImageWidthProperty)property;
            Assert.AreEqual(CssValueType.PrimitiveValue, concrete.Value.CssValueType);
            Assert.IsFalse(concrete.IsInherited);
            Assert.IsTrue(concrete.HasValue);
            Assert.AreEqual("0", concrete.Value.CssText);
        }

        [TestMethod]
        public void CssBorderImageWidthAutoLegal()
        {
            var snippet = "border-image-width: auto";
            var property = CssParser.ParseDeclaration(snippet);
            Assert.AreEqual("border-image-width", property.Name);
            Assert.IsFalse(property.Important);
            Assert.IsInstanceOfType(property, typeof(CSSBorderImageWidthProperty));
            var concrete = (CSSBorderImageWidthProperty)property;
            Assert.AreEqual(CssValueType.PrimitiveValue, concrete.Value.CssValueType);
            Assert.IsFalse(concrete.IsInherited);
            Assert.IsTrue(concrete.HasValue);
            Assert.AreEqual("auto", concrete.Value.CssText);
        }

        [TestMethod]
        public void CssBorderImageWidthMultipleLegal()
        {
            var snippet = "border-image-width: 5";
            var property = CssParser.ParseDeclaration(snippet);
            Assert.AreEqual("border-image-width", property.Name);
            Assert.IsFalse(property.Important);
            Assert.IsInstanceOfType(property, typeof(CSSBorderImageWidthProperty));
            var concrete = (CSSBorderImageWidthProperty)property;
            Assert.AreEqual(CssValueType.PrimitiveValue, concrete.Value.CssValueType);
            Assert.IsFalse(concrete.IsInherited);
            Assert.IsTrue(concrete.HasValue);
            Assert.AreEqual("5", concrete.Value.CssText);
        }

        [TestMethod]
        public void CssBorderImageWidthLengthPercentLegal()
        {
            var snippet = "border-image-width: 10px   25%";
            var property = CssParser.ParseDeclaration(snippet);
            Assert.AreEqual("border-image-width", property.Name);
            Assert.IsFalse(property.Important);
            Assert.IsInstanceOfType(property, typeof(CSSBorderImageWidthProperty));
            var concrete = (CSSBorderImageWidthProperty)property;
            Assert.AreEqual(CssValueType.ValueList, concrete.Value.CssValueType);
            Assert.IsFalse(concrete.IsInherited);
            Assert.IsTrue(concrete.HasValue);
            Assert.AreEqual("10px 25%", concrete.Value.CssText);
        }

        [TestMethod]
        public void CssBorderImageWidthLengthPercentZeroLegal()
        {
            var snippet = "border-image-width: 10px   25% 0";
            var property = CssParser.ParseDeclaration(snippet);
            Assert.AreEqual("border-image-width", property.Name);
            Assert.IsFalse(property.Important);
            Assert.IsInstanceOfType(property, typeof(CSSBorderImageWidthProperty));
            var concrete = (CSSBorderImageWidthProperty)property;
            Assert.AreEqual(CssValueType.ValueList, concrete.Value.CssValueType);
            Assert.IsFalse(concrete.IsInherited);
            Assert.IsTrue(concrete.HasValue);
            Assert.AreEqual("10px 25% 0", concrete.Value.CssText);
        }

        [TestMethod]
        public void CssBorderImageWidthLengthPercentAutoPercentLegal()
        {
            var snippet = "border-image-width: 10px   25% auto 10%";
            var property = CssParser.ParseDeclaration(snippet);
            Assert.AreEqual("border-image-width", property.Name);
            Assert.IsFalse(property.Important);
            Assert.IsInstanceOfType(property, typeof(CSSBorderImageWidthProperty));
            var concrete = (CSSBorderImageWidthProperty)property;
            Assert.AreEqual(CssValueType.ValueList, concrete.Value.CssValueType);
            Assert.IsFalse(concrete.IsInherited);
            Assert.IsTrue(concrete.HasValue);
            Assert.AreEqual("10px 25% auto 10%", concrete.Value.CssText);
        }

        [TestMethod]
        public void CssBorderImageWidthZerosIllegal()
        {
            var snippet = "border-image-width: 0 0 0 0 0";
            var property = CssParser.ParseDeclaration(snippet);
            Assert.AreEqual("border-image-width", property.Name);
            Assert.IsFalse(property.Important);
            Assert.IsInstanceOfType(property, typeof(CSSBorderImageWidthProperty));
            var concrete = (CSSBorderImageWidthProperty)property;
            Assert.AreEqual(CssValueType.Inherit, concrete.Value.CssValueType);
            Assert.IsFalse(concrete.IsInherited);
            Assert.IsFalse(concrete.HasValue);
        }
    }
}
