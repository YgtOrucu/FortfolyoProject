namespace FortfolyoProject.DataAccessLayer.Entities
{
    public class Message
    {
        public int MessageId { get; set; }
        public string Namesurname { get; set; }
        public string Subject { get; set; }
        public string Mail { get; set; }
        public string Details { get; set; }
        public DateTime SendDate { get; set; }
        public bool IsRead { get; set; }
    }
}
