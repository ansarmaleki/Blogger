﻿using Blogger.Domain.Common;

namespace Blogger.Application.Articles.UpdateDraft;
public class DraftNotFoundException : BlogException
{
    private const string _message = "Draft not found.";

    public DraftNotFoundException() : base(_message)
    {

    }
}
