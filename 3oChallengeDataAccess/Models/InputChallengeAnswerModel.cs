﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _3oChallengeDataAccess
{
    public class InputChallengeAnswerModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public UserModel User { get; set; }
        public string Value { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public int InputChallengeId { get; set; }
        public InputChallengeModel InputChallenge { get; set; }
    }
}
