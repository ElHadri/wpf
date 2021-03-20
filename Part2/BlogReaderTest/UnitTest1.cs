using CH07.BlogReader.Models;
using CH07.BlogReader.ViewModels;
using CH07.CookbookMVVM;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace BlogReaderTest
{
    [TestClass]
    public class UnitTest1
    {
        Blog _blog;

        public UnitTest1()
        {
            _blog = new Blog
            {
                Blogger = new Blogger
                {
                    Name = "Homer Simpson",
                    Email = "homer@springfield.com",
                },
                BlogTitle = "Homer vs. World",
                Posts = {
                    new BlogPost {
                        When = new DateTime(2010, 7, 16),
                        Title = "This is my first",
                        Text = "I hate Springfield",
                        Comments = {
                            new BlogComment {
                                Name = "Mr. Bernz",
                                Text = "You're fired!",
                                When = new DateTime(2010, 7, 20)
                            }
                        }
                    },
                    new BlogPost {
                        When = new DateTime(2012, 3, 7),
                        Title = "Second post",
                        Text = "Working is hard",
                        Comments = {
                            new BlogComment {
                                Name = "Lisa S.",
                                Text = "Come on dad!",
                                When = new DateTime(2012, 3, 10)
                            },
                            new BlogComment {
                                Name = "Marge S.",
                                Text = "Homy! stop writing things!",
                                When = new DateTime(2012, 3, 9)
                            }
                        }
                    }

                }
            };
        }

        [TestMethod]
        public void TestAddPost()
        {
            var post = new BlogPost() { Title = "Some title", Text = "Some text" }; // not begin here to understand


            // I will test so I will pass by VM
            var vm = new BlogVM { Model = _blog };
            // prepare what will be happen after pushing the button (trigger a command)
            vm.NewPostDialogService = new AutoDialogService(); /* { ViewModel = new BlogPostVM() { Model = post } };  initialization not needed */
            // now triggering the command
            vm.NewPostCommand.Execute(post);

            Assert.IsTrue(_blog.Posts.Count == 3);

        }
    }
}
