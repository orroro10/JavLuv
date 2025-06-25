using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace JavLuv
{
    public class StringCapitalizeTest
    {
        #region Public Functions

        [Fact]
        public void TestCapitalizeTitle01()
        {
            String s1 = "Simple Test";
            String s2 = Utilities.TitleCapitalize(s1);
            Assert.Equal("Simple Test", s2);
        }

        [Fact]
        public void TestCapitalizeTitle02()
        {
            String s1 = "simple test";
            String s2 = Utilities.TitleCapitalize(s1);
            Assert.Equal("Simple Test", s2);
        }

        [Fact]
        public void TestCapitalizeTitle03()
        {
            String s1 = "here's a simple test of the capitalization";
            String s2 = Utilities.TitleCapitalize(s1);
            Assert.Equal("Here's a Simple Test of the Capitalization", s2);
        }

        [Fact]
        public void TestCapitalizeTitle04()
        {
            String s1 = "here is one. here is two";
            String s2 = Utilities.TitleCapitalize(s1);
            Assert.Equal("Here Is One. Here Is Two", s2);
        }

        [Fact]
        public void TestCapitalizeTitle05()
        {
            String s1 = "here is a title. an excellent title of tests";
            String s2 = Utilities.TitleCapitalize(s1);
            Assert.Equal("Here Is a Title. An Excellent Title of Tests", s2);
        }

        [Fact]
        public void TestCapitalizeTitle06()
        {
            String s1 = "SIMPLE Test";
            String s2 = Utilities.TitleCapitalize(s1);
            Assert.Equal("SIMPLE Test", s2);
        }

        [Fact]
        public void TestCapitalizeTitle07()
        {
            String s1 = "yuri and bite marks: a relationship.";
            String s2 = Utilities.TitleCapitalize(s1);
            Assert.Equal("Yuri and Bite Marks: A Relationship.", s2);
        }

        [Fact]
        public void TestCapitalizeTitle08()
        {
            String s1 = "\"Excuse me! Would you like me?\" A housewife... 4 hours";
            String s2 = Utilities.TitleCapitalize(s1);
            Assert.Equal("\"Excuse Me! Would You Like Me?\" A Housewife... 4 Hours", s2);
        }

        [Fact]
        public void TestCapitalizeTitle09()
        {
            String s1 = "on a 2-day, 1-night trip [leaked video] national ●● basketball club 2024 fall training camp";
            String s2 = Utilities.TitleCapitalize(s1);
            Assert.Equal("On a 2-Day, 1-Night Trip [Leaked Video] National ●● Basketball Club 2024 Fall Training Camp", s2);
        }

        [Fact]
        public void TestCapitalizeTitle10()
        {
            String s1 = "同窓会レズビアンNTR ～恋心を暴走させた絶倫友人に声殺しでイカされ続け夜通し性交でレズ堕ちさせられた婚前巨乳美女～ 小坂ひまり 胡桃さくら";
            String s2 = Utilities.TitleCapitalize(s1);
            Assert.Equal("同窓会レズビアンNTR ～恋心を暴走させた絶倫友人に声殺しでイカされ続け夜通し性交でレズ堕ちさせられた婚前巨乳美女～ 小坂ひまり 胡桃さくら", s2);
        }

        [Fact]
        public void TestCapitalizeTitle11()
        {
            String s1 = "A Girl Who Loves to Dominate and A Girl";
            String s2 = Utilities.TitleCapitalize(s1);
            Assert.Equal("A Girl Who Loves to Dominate and a Girl", s2);
        }

        [Fact]
        public void TestCapitalizeTitle12()
        {
            String s1 = "I will be strong";
            String s2 = Utilities.TitleCapitalize(s1);
            Assert.Equal("I Will be Strong", s2);
        }

        #endregion
    }
}
