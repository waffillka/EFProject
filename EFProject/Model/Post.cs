namespace EFProject.Model
{
    class Post
    {
        public int IdPost { set; get; }
        public string Title { set; get; }
        public string TextPost { set; get; }
        public int? UserId { set; get; }
        //навигационное свойство User
        public User User { set; get; }

        public int? TopicId { set; get; }
        //навигационное свойство Topic
        public Topic Topic { set; get; }

    }
}
