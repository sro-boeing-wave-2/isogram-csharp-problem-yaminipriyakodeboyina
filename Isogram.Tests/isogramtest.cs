using System;
using Xunit;
using Isogram;
namespace Isogramtest
{
    public class isogramtest
    {
        [Fact]
        public void Sentence_empty()
        {
            var result = isogram.Isisogram("");
            Assert.True(result);
        }
        [Fact]
        public void Lowercase_isogram()
        {
            var result = isogram.Isisogram("isogram");
            Assert.True(result);
        }
        [Fact]
        public void Lowercase_eleven()
        {
            var result = isogram.Isisogram("eleven");
            Assert.False(result);
        }
        [Fact]
        public void Lowercase_subdermatoglyphic()
        {
            var result = isogram.Isisogram("subdermatoglyphic");
            Assert.True(result);
        }
        [Fact]
        public void Lower_uppercase_Alphabet()
        {
            var result = isogram.Isisogram("Alphabet");
            Assert.True(result);
        }
        [Fact]
        public void Lower_uppercase_hiphen()
        {
            var result = isogram.Isisogram("thumbscrew-japingly");
            Assert.True(result);
        }
        [Fact]
        public void Lower_duphyphent()
        {
            var result = isogram.Isisogram("six-year-old");
            Assert.True(result);
        }
        [Fact]
        public void Lower_dupspaces()
        {
            var result = isogram.Isisogram("six year old");
            Assert.True(result);
        }
    }
} 