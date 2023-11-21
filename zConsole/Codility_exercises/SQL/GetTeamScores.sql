SELECT t.team_id, t.team_name, COALESCE(SUM(a.score),0) AS num_points FROM
teams t
LEFT JOIN
(
    SELECT match_id, host_team as team_id,
        CASE WHEN host_goals > guest_goals THEN 3
            WHEN guest_goals > host_goals THEN 0
            ELSE 1 END AS score
    FROM matches
    UNION ALL
    SELECT match_id, guest_team as team_id,
        CASE WHEN host_goals > guest_goals THEN 0
            WHEN guest_goals > host_goals THEN 3
            ELSE 1 END AS score
    FROM matches
) a ON t.team_id = a.team_id
GROUP BY t.team_id, t.team_name
ORDER BY num_points DESC, team_id