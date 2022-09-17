﻿using VersOne.Epub.Test.Unit.TestUtils;

namespace VersOne.Epub.Test.Unit.Comparers
{
    internal static class EpubNavigationItemRefComparer
    {
        public static void CompareNavigationItemRefLists(List<EpubNavigationItemRef> expected, List<EpubNavigationItemRef> actual)
        {
            if (expected == null)
            {
                Assert.Null(actual);
            }
            else
            {
                Assert.NotNull(actual);
                AssertUtils.CollectionsEqual(expected, actual, CompareNavigationItemRefs);
            }
        }

        private static void CompareNavigationItemRefs(EpubNavigationItemRef expected, EpubNavigationItemRef actual)
        {
            Assert.NotNull(actual);
            Assert.Equal(expected.Type, actual.Type);
            Assert.Equal(expected.Title, actual.Title);
            EpubNavigationItemComparer.CompareNavigationItemLinks(expected.Link, actual.Link);
            Assert.Equal(expected.HtmlContentFileRef, actual.HtmlContentFileRef);
            CompareNavigationItemRefLists(expected.NestedItems, actual.NestedItems);
        }
    }
}
