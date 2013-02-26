
namespace AE.Net.Mail.Imap {
    public class Mailbox {
        public Mailbox() : this(string.Empty) { }
        public Mailbox(string name) {
            Name = ModifiedUtf7Encoding.Decode(name);
            Flags = new string[0];
        }
        public virtual string Name { get; internal set; }
        public virtual int NumNewMsg { get; internal set; }
        public virtual int NumMsg { get; internal set; }
        public virtual int NumUnSeen { get; internal set; }
        public virtual string[] Flags { get; internal set; }
        public virtual bool IsWritable { get; internal set; }

		/// <summary>
		/// Gets UID that's going to be assigned to the next message in the mailbox (or null if wasn't specified in a server response).
		/// </summary>
		public int? NextUid { get; internal set; }

		/// <summary>
		/// Gets UID of the first unseen message in the mailbox (or null if there's no unseen messages).
		/// </summary>
		public int? FirstUnseenUid { get; internal set; }

		/// <summary>
		/// Gets whether the mailbox has unseen messages.
		/// </summary>
		public bool HasUnseenMessages
		{
			get { return FirstUnseenUid.HasValue; }
		}

        internal void SetFlags(string flags) {
            Flags = flags.Split(' ');
        }
    }
}

