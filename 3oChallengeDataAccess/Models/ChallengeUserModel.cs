namespace _3oChallengeDataAccess
{
    public class ChallengeUserModel
    {
        public int ChallengeId { get; set; }
        public virtual ChallengeModel Challenge { get; set; }
        public int UserId { get; set; }
        public virtual UserModel User { get; set; }
        
    }
}
