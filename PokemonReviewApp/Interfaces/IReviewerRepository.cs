﻿using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviewers();
        Reviewer GetReviewer(int reviewerid);
        ICollection<Review> GetReviewsByReviewer(int reviewerid);
        bool ReviewerExists(int reviewerId);
        bool CreateReviewer (Reviewer reviewer);
        bool UpdateReviewer (Reviewer reviewer);
        bool DeleteReviewer (Reviewer reviewer);
        bool Save();
    }
}
